__author__ = 'Michael'
###                 ###

import sys

def main():
    print "Please enter the name and age of your dog:"
    name = raw_input()
    age = input()
    age = age * 7
    print ("The age of " + name + " in dog years is " + str(age) + ".")
    length = len(name)
    print ("The name of the dog is " + str(length) + " charachters long.")




if __name__ == '__main__':
    main()