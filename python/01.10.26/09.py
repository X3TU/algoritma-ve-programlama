#9. Dışarıdan girilen sayının genişliğini 5 yaparak ekrana yazdırınız. Örneğin dışarıdan girilen sayı =345 ise 00345 şeklinde yazdırılacak.

sayi = int(input("sayi giriniz: "))
print(f"{sayi:05d}")