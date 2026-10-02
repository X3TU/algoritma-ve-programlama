#6. Sistem tarihini gün ve yıl yan yana olarak ekrana yazdırınız.

from datetime import datetime

simdi = datetime.now()

print(simdi.strftime("%d/%y"))
