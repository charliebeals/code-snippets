
import json
import logging
import logging.config
import os
import sys

import SQLConnection

from pathlib import Path


def main():

    # Create logging environment
    logging_ini_path = Path(__file__).resolve().parent / 'logging.ini'
    logging.config.fileConfig(logging_ini_path)
    mainLogger = logging.getLogger('root')

    # Create header in log file
    mainLogger.info("____________________")
    mainLogger.info("Entering Application")
    mainLogger.info("--------------------")

    # Get configs
    configsListPath = input("Path to your config file: ")
    if configsListPath == "":
        configsListPath = "C:\data\configs.json"
    try:
        assert os.path.exists(
            configsListPath), "File does not exist at " + str(configsListPath)
    except AssertionError:
        subLogger.warning(f"Failed to find csv file at {configsListPath}")
    try:
        with open(configsListPath) as json_config_file:
            cfg = json.load(json_config_file)
    except KeyError:
        print("KeyError")

    data = ""
    exit_sentinel = False
    currentEnvironment = {}

    # Initiate Menu Loop
    while exit_sentinel == False:

        # Print CLI pointer with environment if applicable
        try:
            envName = currentEnvironment["name"]
        except:
            envName = "null"
        command = input(f"env: {envName}>")

        # Check given command
        if command == "env":
            print("Available Environments:")
            for env in cfg:
                print(f"      {env}")

            valid_environment = False
            while valid_environment == False:
                selectedEnvironment = input("select an environment: ")
                try:
                    currentEnvironment = cfg[selectedEnvironment]
                    valid_environment = True
                except KeyError:
                    print(f"'{selectedEnvironment}'' is not a valid choice")
                    valid_environment = False

        elif command == "connect":
            if currentEnvironment:
                sql = SQLConnection.SQLConnection(currentEnvironment)
                sql.name = currentEnvironment["name"]
                sql.host = currentEnvironment["host"]
                sql.user = currentEnvironment["user"]
                sql.password = currentEnvironment["password"]
                sql.database = currentEnvironment["database"]
                sql.menu()
            else:
                print("Please use 'env' to select an environment first")
        elif command == "exit" or command == "quit":
            exit_sentinel = True
        else:
            main_menu_selection = "none"


main()
