__author__ = 'Michael Spector'
"""This Program takes the math exercises that are in the exercises file and
calculates the answers and puts them in an answers file."""


import sys
import os


EXERCISES = 1
RESULTS = 2


def is_float(my_string):
    """Checks if a given string is a float."""
    try:
        float(my_string)
        return True
    except ValueError:
        return False


def lines_in_file():
    """"Returns the number of lines in a single .txt file"""
    counter = 0
    with open(sys.argv[EXERCISES], 'r') as opened_file:
        for line in opened_file:
            line.isalpha()
            counter += 1
    return counter


def file_to_list():
    """Extracts text from file and splits every line into it's own string,
    puts all the strings into a list and returns that list."""
    with open(sys.argv[EXERCISES], 'r') as exercise_file:
        line_list = exercise_file.read().split('\n')
    return line_list


def list_splitter(line_num):
    """Splits a list by space-bars."""
    line_list = file_to_list()
    parts_list = line_list[line_num].split(' ')
    return parts_list[0], parts_list[2], parts_list[1], line_list


def solving_area(line_num):
    """Receives all the parameters to perform mathematical equations,
     and prints the equations + answers into the results file."""
    num1, num2, operator, line_list = list_splitter(line_num)

    if operator == '+':
        solution = float(float(num1) + float(num2))
        if str(solution).endswith('.0'):
            solution = str(solution).replace('.0', '')
        solve_string = str(line_list[line_num]) + ' = ' + str(solution)
        append_solution_to_file(solve_string)
    elif operator == '-':
        solution = float(float(num1) - float(num2))
        if str(solution).endswith('.0'):
            solution = str(solution).replace('.0', '')
        solve_string = str(line_list[line_num]) + ' = ' + str(solution)
        append_solution_to_file(solve_string)
    elif operator == '*':
        solution = float(float(num1) * float(num2))
        if str(solution).endswith('.0'):
            solution = str(solution).replace('.0', '')
        solve_string = str(line_list[line_num]) + ' = ' + str(solution)
        append_solution_to_file(solve_string)
    elif operator == '/':
        if int(num2) != 0:
            solution = float(float(num1) / float(num2))
            if str(solution).endswith('.0'):
                solution = str(solution).replace('.0', '')
            solve_string = str(line_list[line_num]) + ' = ' + str(solution)
            append_solution_to_file(solve_string)
        else:
            solve_string = str(line_list[line_num]) + ' = ' + 'Illegal exercise'
            append_solution_to_file(solve_string)


def line_input_check(line_num):
    """Checks if the input of that specific line is without errors."""
    check_file_list = file_to_list()
    individual_arguments = check_file_list[line_num].split(' ')

    if len(individual_arguments) != 3:
        return False
    elif individual_arguments[1] != '+' and individual_arguments[1] != '-'\
            and individual_arguments[1] != '*' and individual_arguments[1] != '/':
        return False
    elif (is_float(individual_arguments[0]) is False) \
            or (is_float(individual_arguments[2]) is False):
        return False
    else:
        return True


def arguments_check():
    """Checks that the arguments that the user inputs are correct."""
    if os.path.isfile(sys.argv[EXERCISES]) is False:
        print "Exercise file cannot be found"
        return False
    elif os.path.isfile(sys.argv[RESULTS]) is False:
        print "Results file cannot be found"
        return False
    if str(sys.argv[EXERCISES]).endswith('.txt') is False:
        print "Exercises file is not a .txt file"
        return False
    elif str(sys.argv[RESULTS]).endswith('.txt') is False:
        print "Results file is not a .txt file"
        return False
    if sys.argv[EXERCISES] == sys.argv[RESULTS]:
        print "Exercises file cannot be the same as the Results file"
        return False
    return True


def append_solution_to_file(answers_string):
    """Receives a solution for the problem and appends it to a file."""
    with open(sys.argv[RESULTS], 'a+') as answers_file:
        answers_file.write(str(answers_string) + '\n')


def clear_last_solve_file():
    """Clears the cache of the Results file."""
    print ''
    print 'Clear the current results file? Enter yes, if you wish so. Otherwise, no.'
    print ''
    answer = raw_input()
    print ''
    if answer.lower() == 'yes':
        with open(sys.argv[RESULTS], 'w+') as using_file:
            using_file.write('')
        print 'Deleted old cache...'
    else:
        print 'Keeping old cache...'


def main():
    """This is the main function. Runs the code """
    if arguments_check():
        line_list = file_to_list()
        num_of_lines = lines_in_file()
        clear_last_solve_file()
        for i in range(num_of_lines):
            if line_input_check(i):
                solving_area(i)
            else:
                solve_string = str(line_list[i]) + ' = ' + 'Illegal exercise'
                append_solution_to_file(solve_string)


if __name__ == '__main__':
    main()
