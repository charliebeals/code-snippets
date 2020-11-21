import csv
import json
import logging
import os
import sys

from objects import apple
from pathlib import Path


class ApplesNavigation():

    def __init__(self):
        return

    def menu(self):

        # Initiate Menu Loop
        selection = "none"
        data = "none"
        while selection == "none":
            command = input(">>")
            if command == "get data":
                data = ApplesNavigation.OpenCSVFile()
            elif command == "display all":
                if data == "none":
                    print("No data. Please run 'get data' first")
                else:
                    ApplesNavigation.DisplayAll(data)
            elif command == "filter":
                if data == "none":
                    print("No data. Please run 'get data' first")
                else:
                    data = ApplesNavigation.Filter(data)
            else:
                print(f"invalid command '{command}'")
                selection = "none"

    def OpenCSVFile():

        subLogger = logging.getLogger(__name__)

        returnValue = "back"

        command = input("Enter path: ")
        if command == "back":
            subLogger.info("Moving back to Main Menu")
        else:
            inputPath = command
            try:
                assert os.path.exists(
                    inputPath), "File does not exist at " + str(input)
            except AssertionError:
                subLogger.warning(f"Failed to find csv file at {inputPath}")
                returnValue = "back"
            try:
                with open(file=inputPath, mode="r") as csv_file:
                    data = csv.DictReader(csv_file)
                    allObjects = []
                    for row in data:
                        line = apple.Apple()
                        line.specific = row["ID"]
                        line.orchard = row["O"]
                        line.species = row["T"]
                        line.color = row["C"]
                        line.eaten = row["W"]
                        line.good = row["F"]
                        line.finished = row["E"]
                        allObjects.append(line)
                    subLogger.info(f"Data Loadeed from {inputPath}")
                    returnValue = allObjects
            except FileNotFoundError:
                subLogger.warning(f"Failed to find csv file at {inputPath}")
                returnValue = "back"

        return returnValue

    def DisplayAll(data):
        for apple in data:
            print(f"{apple.specific}: a {apple.species} owned by {apple.orchard}. Colored {apple.color}, eaten {apple.eaten}, good {apple.good}, finished {apple.finished}")

    def Filter(data):
        print("Available attributes:")
        print("specific")
        print("orchard")
        print("species")
        print("color")
        print("eaten")
        print("good")
        print("finished")

        filterAttribute = input("Enter attribute to filter on: ")
        filterValue = input("Enter filter parameter: ")

        filterOutput = []
        for apple in data:
            if apple.filterAttribute == filterValue:
                filterOutput.append(apple)

        return filterOutput
