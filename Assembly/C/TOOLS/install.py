import sys
import os

CONF_FILE_NAME = "conf.conf"


def repalce_vars(path, vars_to_replace):
    with open(CONF_FILE_NAME, "r+") as confFile:
            data = confFile.read()
            for var, value in vars_to_replace.items():
                data = data.replace(var, value)
            confFile.seek(0)
            confFile.write(data)


def createShortcut(confFile):
    os.system(
        'echo start "DosBox" dosbox.exe -conf {}>start.bat'.format(confFile));


def main():
    try:
        vars_to_replace = {
            "%cPath%": sys.argv[0][:r"C:\Users\mikis\OneDrive\Desktop\Coding\Assembly\C\TOOLS\install.py".rindex(r"\tools")],
            "%toolsPath%": r"C:\TOOLS"
        }
        repalce_vars(CONF_FILE_NAME, vars_to_replace)
        createShortcut(
            sys.argv[0][:r"C:\Users\mikis\OneDrive\Desktop\Coding\Assembly\C\TOOLS\install.py".rindex("\\") + 1] + CONF_FILE_NAME)
    except Exception as e:
        raise
        print("\nError:\n\n")
        #print(e, e.with_traceback())
        print("\nPress enter to exit")
        input()
        sys.exit(1)
    else:
        sys.exit(0)


if __name__ == "__main__":
    main()
