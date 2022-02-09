import math

def exceptions():
    try:
       a = open("./Rahin.txt")
    except Exception as e :
        print(e)
if __name__ == "__main__":
    exceptions()
