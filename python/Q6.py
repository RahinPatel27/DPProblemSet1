vowel_list = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U',]

def pig(a):
    if a[0] not in vowel_list:
        print(a[1:]+a[:1]+"ay")
    else:
        print(a+ "way")


if __name__ == "__main__":
    pig("happy")
