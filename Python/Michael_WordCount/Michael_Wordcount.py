__author__ = 'Michael Spector'
#


import sys
import os
import re
from collections import Counter


TEXT_FILE = 'alice.txt'
DESTINATION_FILE_LOCATION = 2
COUNTING_METHOD_LOCATION = 1
OUTER_PUNCTUATION = r"\"!@#$%^&*()?><,.{}[]/=-_`+|~;:1234567890'"
INNER_PUNCTUATION = r"[\"@\#$\%\^\&\*()?\>\<,\.{}\[\]\|\+/=_`~;:0-9\!-]+"


def count():
    words = split_file_to_words()
    results = []
    for word in sorted(words.keys()):
        results.append("{}: {}".format(word, words[word]))
    return results


def top_count(top=20):
    words = Counter(split_file_to_words())
    results = []
    for word, entries in words.most_common(top):
        results.append("{}: {}".format(word, entries))
    return results


FUNCTIONS = {
    "--count": count,
    "--topcount": top_count
}


def split_file_to_words():
    words = {}
    with open(TEXT_FILE, 'r') as file:
        for line in file:
            split_line_to_words(words, line.rstrip().lower())
    return words


def split_line_to_words(words, line):
    for word in line.split(' '):
        word = word.rstrip(OUTER_PUNCTUATION).lstrip(OUTER_PUNCTUATION)
        for inner_word in re.split(INNER_PUNCTUATION, word):
            if inner_word:
                current_value = words.get(inner_word, 0)
                words.setdefault(inner_word, 0)
                words[inner_word] = current_value + 1


def args_check():
    if len(sys.argv) != 3:  # checks if the correct number of arguments is present
        print("Incorrect number of arguments")
        return False
    counting_method = sys.argv[COUNTING_METHOD_LOCATION]
    destination_file = sys.argv[DESTINATION_FILE_LOCATION]
    if counting_method not in FUNCTIONS.keys():  # checks if the counting methods are valid
        print("Invalid counting method {}. Should be one of {}".format(sys.argv[1], list(FUNCTIONS.keys())))
        return False
    if os.path.splitext(destination_file)[1] != ".txt":
        print("The destination file extension is invalid({}). Please make sure it is .txt".format(
            os.path.splitext(destination_file)[1]))
        return False
    return True


def list_to_file(lines):
    with open(sys.argv[DESTINATION_FILE_LOCATION], 'w+') as destination_file:
        for line in lines:
            destination_file.write("{}\n".format(line))


def main():
    if args_check():
        result = FUNCTIONS[sys.argv[COUNTING_METHOD_LOCATION]]()
        list_to_file(result)


if __name__ == '__main__':
    main()
