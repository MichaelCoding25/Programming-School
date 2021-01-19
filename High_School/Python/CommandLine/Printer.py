import sys


__author__ = 'Michael'
#                #


FILE = 1


def main():
    with open(sys.argv[FILE], 'r') as input_file:
        name = input_file.read()
        print 'Hello', name


if __name__ == '__main__':
    main()
