def bldcount():

    with open('./bloodtype1.txt') as f:
        for a in f:
            total = a.split()
            GroupAB = 0
            GroupB = 0
            GroupA = 0
            GroupO = 0
            GroupOO = 0
            for i in total:
                if i == "AB":
                    GroupAB = GroupAB + 1
                if i == "B":
                    GroupB = GroupB + 1
                if i == "O":
                    GroupO = GroupO + 1
                if i == "A":
                    GroupA = GroupA + 1
                if i == "OO":
                    GroupOO = GroupOO + 1
            print(f'There are {GroupA} patients of blood type A.')
            print(f'There is {GroupB} patient of blood type B')
            print(f'There are {GroupAB} patients of blood type AB.')
            print(f'There are {GroupO} patients of blood type O.')
            print(f'There are {GroupOO} patients of blood type OO.')
if __name__ == "__main__": 
    bldcount()