import sys

month = ' '
rightMonth = "May"
print("Hello user, what month was I born in?")
month = raw_input()

while month != rightMonth:
    if month == "exit":
        sys.exit()
        
    else:
        print "What month was I born in?"
        month = raw_input()
        
print "Well Done!"    
