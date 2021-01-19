__author__ = 'Michael'
# The program takes a text file and transfers it's contents to another file #
# The file Song.txt and EmptyFile.txt need to be in the same folder as the .py program #


def main():
    song_file = open(r'.\Song.txt', 'r')
    song_lyrics = song_file.read()
    empty_file = open(r'.\EmptyFile.txt', 'w')
    empty_file.write(song_lyrics)
    empty_file.close()
    new_song_file = open(r'.\EmptyFile.txt', 'r')
    new_song_lyric = new_song_file.read()
    print new_song_lyric
    song_file.close()
    new_song_file.close()


if __name__ == '__main__':
    main()
