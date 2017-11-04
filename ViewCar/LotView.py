import sqlite3
import cv2

DataBaseName = "Cars.db"

class LotView(object):
    """This is built to run the lot"""
    SqlFile = DataBaseName
    def __init__(self):
        return

    def SaveCount(self, name, newCount):
        """Writes to the sqlite file the new Count"""
        try:
            conn = sqlite3.connect(self.SqlFile)
            c = conn.cursor()
            #Connect to the Database, check for errors as we go...
            c.execute('''UPDATE Lots SET COUNT=? WHERE NAME=?''', (newCount, name))
            conn.close()
        finally:
            pass
        return

    def CreateLot(self, ID, Location, LotName, Maxsize, CurrentCount):
        """This is to create a new row in the database with the table name, mostly for testing purposes"""
        try:
            #connect to database and check if lot exists
            conn = sqlite3.connect(self.SqlFile)
            c = conn.cursor()
            c.execute('''SELECT * FROM LOTS WHERE ID=?''', (ID,))


            #Insert new Lot into database
            c.execute('''INSERT INTO Lots VALUES (?,?,?,?,?)''', (ID, Location, LotName, Maxsize,CurrentCount))
            conn.close()
        finally:
            pass
        return

    def CreateTable(self):
        try:
            conn = sqlite3.connect(self.SqlFile)
            c = conn.cursor()
            #Connect to the Database, check for errors as we go...
            c.execute('''CREATE TABLE Lots (
                        ID int,
                        Location text,
                        Lotname text,
                        Maxsize int,
                        CurrentCount int)''')
            conn.close()
        finally:
            pass
        return
    def CheckCamera(self):
        Count = 0
        
        return Count