__author__ = 'Michael Spector'
# This program takes an input of 5 digits from the user, checks if it is correct, #
# and then,  prints the number that the user wrote, it's digits and the sum of it's digits. #


MAX_LENGTH = 5


def print_individual_characters(input_string):
    """
    Takes a string and prints the individual characters inside of it.
    :param input_string: A string that the characters of need to be printed.
    :return: prints the individual digits of the string.
    """
    for character_index in range(len(input_string)):
        if character_index is len(input_string) - 1:
            print input_string[character_index],
        else:
            print input_string[character_index] + ",",


def number_sum(num):
    """
    Takes a number and return the sum of the number's digits.
    :param num: A String
    :return sum: An int
    """
    return sum(int(index) for index in num if index.isdigit())


def input_check(first_input):
    """
    Takes an input (string) and checks if the string is 5 digits.
    :param first_input: A string that needs to be checked.
    :return: A boolean value that indicates if the input that was entered is correct.
    """
    if (len(first_input) != MAX_LENGTH) or (first_input.isdigit() is False):
        return False
    else:
        return True


def main():
    print "Please enter a 5 digit number:"
    user_input = raw_input()
    while input_check(user_input) is False:
        print 'You entered an incorrect input, please enter a ' + str(MAX_LENGTH) + ' digit number again:'
        user_input = raw_input()

    print 'You entered the number: ' + user_input
    print 'The digits of this number are: '
    print_individual_characters(user_input)
    print
    print 'The sum of the digits is: ' + str(number_sum(user_input))


if __name__ == '__main__':
    main()
