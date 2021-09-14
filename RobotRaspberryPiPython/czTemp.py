#!/usr/bin/python

import time

import MCP9808

sensor = MCP9808.MCP9808()

sensor.begin()


def WynikTemp():
        temp = sensor.readTempC()
        temp = round(temp,0)
        reply = str(temp)
        return reply
