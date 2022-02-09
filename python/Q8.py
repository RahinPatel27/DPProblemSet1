def curconv(curr,amount):
    with open('./currencies.txt') as f:
        lines = [line.rstrip('\n') for line in f]
        for i in lines:
            if (i.split()[0] == curr): 
                finalAmount = float(i.split()[1]) * 100
                print(finalAmount,f'\nThis is the final amount for {curr}, {amount}')
    

if __name__ == "__main__": 
    curconv('EUR',100)
