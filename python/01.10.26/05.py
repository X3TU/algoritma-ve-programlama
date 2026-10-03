#5. Sistem saatini saat ve dakika cinsinden yazdırınız.

from datetime import datetime

simdi = datetime.now()

print(simdi.strftime("%H:%M"))

