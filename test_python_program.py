from util.fizzbuzz import fzbz


def main():
    msg = "1から100までの自然数nについて、\n"\
        + "　・nが3の倍数のとき、Fizzを出力する\n"\
        + "　・nが5の倍数のとき、Buzzを出力する\n"\
        + "　・nが3の倍数かつ5の倍数のとき、FizzBuzzを出力する\n"\
        + "　・nが3の倍数でも5の倍数でもないとき、nをそのまま出力する\n"
    print(msg)

    for i in range(1, 101):
        #別プログラムにしてみる
        fzbz(i)

    print("\n終わりです！")

if __name__ == "__main__":
    main()
