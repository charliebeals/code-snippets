import json
import logging
import os
import sys

from pathlib import Path


class Display():

    def __init__(self):
        return

    def displayMainMenu(self, data):

        subLogger = logging.getLogger(__name__)

        print(data)