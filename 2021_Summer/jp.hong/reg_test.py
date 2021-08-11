from winreg import *
import sys
#HKLM\SYSTEM\CurrentControlSet\Enum\USB

for k in range(3):
    try:
        k = ("SYSTEM\\CurrentControlSet\\Enum\\USBSTOR\\Disk&Ven_SCSI&Prod_DISK&Rev_1.00", "SYSTEM\\CurrentControlSet\\Enum\\USBSTOR\\Disk&Ven_SanDisk&Prod_Ultra&Rev_1.00", "HKLM\SYSTEM\CurrentControlSet\Enum\USB")
        varSubkey = k
        varReg = ConnectRegistry(None, HKEY_LOCAL_MACHINE)
        varKey = OpenKey(varReg, varSubkey)
    except:
        errorMsg = "Null", sys.exc_info()[0]
for i in range(1024):
    try:
        keyname = EnumKey(varKey, i)
        varSubkey2 = "%s\\%s" % (varSubkey, keyname)
        varKey2 = OpenKey(varReg, varSubkey2)
        try:
            for j in range(1024):
                n, v, t = EnumValue(varKey2, j)
                if("FriendlyName" in n and "USB" in v):
                    print(v)
        except:
            errorMsg = "Exception Inner:", sys.exc_info()[0]
        CloseKey(varKey2)
    except:
        errorMsg = "Exception Outter:", sys.exc_info()[0]
        break
    CloseKey(varKey)
    CloseKey(varReg)





# 'C:/Users/wow/Desktop/data/data.txt'
# 'https://lafirr.tistory.com/129'
