#9. Dışarıdan girilen sayının genişliğini 5 yaparak ekrana yazdırınız. Örneğin dışarıdan girilen sayı =345 ise 00345 şeklinde yazdırılacak.

sayi = input("sayi giriniz: ")

isaret = ""
if sayi.startswith("-"):
    isaret = "-"
    sayi = sayi[1:]

sifirsayisi = 5 - len(sayi)
print(isaret, "0"*sifirsayisi, sayi, sep="")