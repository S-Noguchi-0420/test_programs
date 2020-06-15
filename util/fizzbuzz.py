def main():
    print("mainメソッドを実行することは無い想定")

def fzbz(n):
    if n % 15 == 0:
        print("FizzBuzz")
    elif n % 3 == 0:
        print("Fizz")
    elif n % 5 == 0:
        print("Buzz")
    else:
        print(n)

if __name__ == "__main__":
    main()
