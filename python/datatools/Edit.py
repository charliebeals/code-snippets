import json
import logging
import os
import sys

from pathlib import Path


class Edit():

    def __init__(self):
        return

    def displayMainMenu(self, data):

        subLogger = logging.getLogger(__name__)

        go_back = False
        while go_back == False:
            command = input(">edit >>")
            if command == "d":
                Display.printDataRaw(self, data)
            elif command == "back":
                go_back = True

    def printDataRaw(self, data):
        raw_data = data[0]
        data_source = data[1]
        data_type = data[2]
        print(json.dumps(raw_data, indent=1))
