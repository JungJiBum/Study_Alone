one = int(input()) # 150
two = int(input()) # 266
three = int(input()) # 427

# ls = one * two * three
# print(ls)
# ls1 = str(ls)
# print(ls1)
# ls2= list(ls1)
# print(ls2)
rs = list(str(one*two*three)) # 17,037,300숫자를 문자열로 리스트화
print(rs)

for i in range(1,10):
    print(rs.count(str(i)))
    #0 부터 9까지 갯수 카운트