A = int(input())  # 150
B = int(input())  # 266
C = int(input())  # 427

rs = list(str(A*B*C))  # 17,037,300숫자를 문자열로 리스트화

for i in range(0, 10):
    print(rs.count(str(i)))
    # 0 부터 9까지 갯수 카운트
