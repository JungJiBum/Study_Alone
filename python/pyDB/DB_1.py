# STEP 1 임포트
from telnetlib import IP
import pandas as pd
from psutil import users
import pymysql

# # STEP 2 MySQL Connection 연결
# con = pymysql.connect(host='10.10.200.130',
#                       user='root',
#                       password='123qwe',
#                       db='TEST',
#                       charset='utf8',
#                       cursorclass=pymysql.cursors.DictCursor)

# #  STEP 3 Connection 으로부터 Cursor 생성
# cur = con.cursor()

# # STEP 4 SQL문 실행 및 Fetch
# sql = "SELECT * FROM SIGN"
# cur.execute(sql)

# # 데이터 Fetch
# rows = cur.fetchall()
# # print(f"DB 값 : {rows}")
# df_rows = pd.DataFrame(rows)
# print(df_rows)


# # STEP 5 DB 연결 종료
# con.close()

class DB_CONNECT:


    #생성자
    def __init__(self,host,database,username,password):
        self.host = host
        self.database = database
        self.username = username
        self.password = password
    
    #출력
    def print_info(self):
        print("=====접속정보=====")
        print(f"HOST : {self.host} / username : {self.username} / password : {self.password}")
    
    def connect_db(self):
        con = pymysql.connect(host = self.host,
        user=self.username,
        password=self.password,
        db=self.database,
        charset='utf8',
        cursorclass=pymysql.cursors.DictCursor)
        
        cur = con.cursor()

        sql = "SELECT * FROM SIGN"
        cur.execute(sql)
        rows = cur.fetchall()
        df_rows = pd.DataFrame(rows)
        print(df_rows)
        con.close()
        print("연결종료")
        
IP = input("입력 주소 ? : ")
DB = input("DB 명 ? : ")
users = input("user명 ? : ")
pw = input("pw ? : ")

test = DB_CONNECT(IP,DB,users,pw)
test.print_info()
test.connect_db()