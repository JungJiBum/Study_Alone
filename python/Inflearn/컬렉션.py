'''
(1) 리스트 - list
(2) 튜플 - tuple
(3) 집합 - set
(4) 딕셔너리(사전) - dict
'''
'''
#[1] 리스타가 없다면...
person1_name= '홍길동'
person1_age = '33'
person1_address= '대한민국'
person1_tel = '010-1234-5678'

print(person1_name)
print(person1_address)
print(person1_age)
print(person1_tel)
# 일일이 해줘야함
#[2] 리스트가 있다면...
person1 = ['홍길동',33,'대한민국','010-1234-5678']
print(person1)
'''

#[1] 정수,실수,문자형 리스트 생성
# int_ls = [1,2,3,4,5]
# flo_ls = [1.0,2.0,3.0,4.0,5.0]
# str_ls = ['a','b','c','d','e']
# print(int_ls,type(int_ls))
# print(flo_ls,type(flo_ls))
# print(str_ls,type(str_ls))

#[2] 리스트 생성 서로 다른 데이터 자료형 값 사용
# INT_LS = [1,2,3,4,5,['a','b''c']]
# INT_FLO_STR = [100,3.14,'korea',[1,2,3]]
# INT_LS_TUP = [1,2,3,[1,2,3],(1,2,3)]
# ALL_LS = [100,3.14,'korea',[1,2,3],(1,2,3),{1,2,3},{'a':100,'b':200,'c':300}]
# print(INT_LS,type(INT_LS))
# print(INT_FLO_STR,type(INT_FLO_STR))
# print(INT_LS_TUP,type(INT_LS_TUP))
# print(ALL_LS,type(ALL_LS))


#[3] 빈 리스트 생성 코드 2가지
# a = [1,2,3,3]
# b = list()
# c = set(a)
# print("빈 리스트 생성 방식 :",a,type(a))
# print("빈 리스트 생성 방식 :",b,type(b))
# print("빈 리스트 생성 방식 :",c,type(c)) #set 함수는 중복값을 가질수 없음

#[4] 인덱스 이용하여 리스트 요소 접근 및 출력
# a = [100,200,300,400,500]
# print("인덱스를 이용한 a 리스트 요소 출력 :",a[0],a[1],a[2],a[3],a[4])
# print(a[-1])

#[5] 리스트에서 특정 요소만 출력
# a = [100,3.14,'korea',[1,2,3,365],(100,200,300,400,500)]
# print(a[2])
# print(a[3][3])
# print(a[4][3])

#[6] 역인덱스 사용하기
# a = [100,200,300,400,500]
# print("인덱스를 이용한 출력 : ",a[:])
# print("역 인덱스를 이용한 출력 : ",a[::-1])

#[7] 반복문 사용하여 인덱스 리스트 값 출력
# a=[100,200,300,400,500,[1,2,3,],(4,5,6)]

# num=0
# for i in a:
#     print(f"{num} = {i}", end="\t")
#     num+=1

#[8] 영어점수를 오름 차순 출력
eng_scores= [100,40,70,90,60]

