#1. Dışarıdan girilen 3x3 lük bir matrisi, matris biçiminde ekrana yazdırınız.

###1.çözüm###

a = int(input("1. sayı: "))
b = int(input("2. sayı: "))
c = int(input("3. sayı: "))
d = int(input("4. sayı: "))
e = int(input("5. sayı: "))
f = int(input("6. sayı: "))
g = int(input("7. sayı: "))
h = int(input("8. sayı: "))
i = int(input("9. sayı: "))

print(a, b, c)
print(d, e, f)
print(g, h, i)

#yada

print(f"{a}\t{b}\t{c}\n{d}\t{e}\t{f}\n{g}\t{h}\t{i}")


###2.çözzüm for loop ile###
"""
matris=[]
for i in range(3):
    satir = []
    for x in range(3):
        satir.append(int(input("sayı giriniz:")))
    matris.append(satir)

for satir in matris:
    print(satir, end="\n")


"""