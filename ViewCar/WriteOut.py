import sqlite3

DataBaseName = "Cars.db"


def saveCount(name, newCount):
    try:
        conn = sqlite3.connect(DataBaseName)
        c = conn.cursor()
        #Connect to the Database, check for errors as we go...
        c.execute('''UPDATE Lots SET COUNT=(?) WHERE NAME=(?)''',(newCount, name))
        conn.close()
    finally:
        pass
    return