####################################################################
########################## Advent of Code ##########################
####################################################################

# Day 2, Task 2

#Confident that your list of box IDs is complete, you're ready to find the 
# boxes full of prototype fabric.

# The boxes will have IDs which differ by exactly one character at the same 
# position in both strings. For example, given the following box IDs:
# 
# abcde
# fghij
# klmno
# pqrst
# fguij
# axcye
# wvxyz
# The IDs abcde and axcye are close, but they differ by two characters (the 
# second and fourth). However, the IDs fghij and fguij differ by exactly one 
# character, the third (h and u). Those must be the correct boxes.
# 
# What letters are common between the two correct box IDs? (In the example above, 
# this is found by removing the differing character from either ID, producing fgij.)

path = "C:\chuck\Advent Of Code\day 2_1 input.txt"

# Open the puzzle input file, load each line into puzzleInput dictionary
with open(path) as p:
    content = p.readlines()
puzzleInput = [line.rstrip('\n') for line in content]

# Itterate through the items, checking each one against all the others to find one
# where a single character in a postition is different
for topLine in puzzleInput:
    for bottomLine in puzzleInput:
        misses = 0
        for x, y in zip(topLine, bottomLine):
            if x != y:
                misses +=1
        if misses == 1:
            print(topLine + " matches " + bottomLine)