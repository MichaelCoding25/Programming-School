__author__='Michael Spector'
##                     ##

import sys

def last_char(word):
    """ Return the last character of word
    Args:
        word - a string
    """
    return word[-1]

def Listing(sentence):
    """ Print words of sentence and sort and print sentence in different ways
     Args:
        sentence - a string
    """
    words = sentence.split()
    print "The sentence split into words:"
    for i in range(len(words)):
        print(words[i])
    print('')
    words.sort()
    print "The words sorted by first letter (A to Z):"
    for i in range(len(words)):
        print(words[i])
    print('')
    words.sort(reverse=True)
    print "The words sorted by first letter (Z to A):"
    for i in range(len(words)):
        print(words[i])
    print('')
    words.sort(key=last_char)
    print "The words sorted by last letter (Z to A):"
    for i in range(len(words)):
        print(words[i])
    print('')
    words.sort(key=len, reverse=True)
    print "The words sorted by length (From longest to shortest):"
    for i in range(len(words)):
        print(words[i])
    print('')
    words_sorted = []
    for i in range(len(words)):
        words_sorted.append(len(words[i]))
    print "The number of characters in each word in the sentence from highest to lowest:"
    for i in range(len(words_sorted)):
        print(words_sorted[i])
    print('')



def main():
    user_input = "hello i am very handsome"
    Listing(user_input)





if __name__ == '__main__':
    main()