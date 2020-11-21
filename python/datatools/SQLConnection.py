import csv
import json
import logging
import os
import sys
import mysql.connector
from objects import apple

from pathlib import Path


class SQLConnection():

    name = ""
    host = ""
    user = ""
    password = ""
    database = ""

    def __init__(self, environment):
        return

    def CreateSQLConnection(self):

        return mycursor

    def menu(self):

        # Set logging
        subLogger = logging.getLogger(__name__)

        # Connect to database
        mydb = mysql.connector.connect(
            host=self.host,
            user=self.user,
            password=self.password,
            database=self.database
        )
        mySQLConnection = mydb.cursor()

        saved_list = []
        saved_item = []
        exit_sentinel = False

        while exit_sentinel == False:
            command = input(f"env: {self.name}[CONNECTED]>")
            if command == "list all":
                mySQLConnection.execute("SELECT * FROM sheet3")
                my_result = mySQLConnection.fetchall()
                saved_list = my_result
                for line in my_result:
                    print(line)
            elif command == "custom":
                customCommand = input("Type command: ")
                mySQLConnection.execute(customCommand)
                my_result = mySQLConnection.fetchall()
                saved_list = my_result
                for line in my_result:
                    print(line)
            elif command == "select id":
                selected_id = input("Enter id: ")
                mySQLConnection.execute(
                    f"select * from sheet3 where id={selected_id}")
                my_result = mySQLConnection.fetchall()
                saved_item = my_result
                print(my_result)
            elif command == "translate list":
                if saved_list:
                    for item in saved_list:
                        personID = item[1]
                        mySQLConnection.execute(
                            f"SELECT * FROM people where PersonID={personID}")
                        person = mySQLConnection.fetchall()
                        print(person)
                else:
                    print("Please enter a query first")
            elif command == "disconnect":
                exit_sentinel = True

    #def translate():
