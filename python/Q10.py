
Alphabet=['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z']

def frequencies(text):
    totalCount = []
    for i in range(0,26):
        totalCount.append(text.count(Alphabet[i]))
    print(totalCount)


if __name__ == "__main__": 
    frequencies('apple')