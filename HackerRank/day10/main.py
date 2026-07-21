#!/bin/python3

import math
import os
import random
import re
import sys



if __name__ == '__main__':
    n = int(input().strip())

    binary = bin(n)[2:]
    
    max_count = 0
    current_count = 0
    for digit in binary:
        if digit == '1':
            current_count += 1
            max_count = max(max_count, current_count)
        else:
            current_count = 0
    
    print(max_count)