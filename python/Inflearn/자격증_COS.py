# [문제유형 1] 1차원 배열의 반복문을 돌면서 입력한 무게 이상의 수박들을 찾아내는 유형.
# [문제유형 2] 반복문을 중첩으로 사용하면서 2차원 배열을 만들고 그 안에서 조건을 비교하여 결과를 찾아내는 유형.


'''
1번
과일 가게에 수박이 들어왔는데 각각 무게는 다음과 같다. --> 5, 7, 9, 12, 15
이중 10kg 이상인 수박들의 무게와 개수를 출력해라.
입력값 -> lst, k(10), 리턴값 ->2, 함수명 ->solution()
'''
#---------------------------
# def solution(lst, k):
#     # 빈 리스트 생성
#     ans = []
#     cnt = 0
#     # lst 길이만큼 돌면서 10kg 이상인 수박 찾기
#     for i in lst:
#         if i >= k:
#             ans.append(i)
#             cnt +=1
#     return ans#, cnt
# #---------------------------

# rst = solution([5,7,9,12,15],10)
# # print(f"무게는 {rst[0]}, 개수는 {rst[1]}개")
# print(f"무게는 {rst}, 개수는 {len(rst)}개")


'''
4x5 shape의 2차원 배열을 만들고 각 요소를 순회하는 코드를 구현
각 요소의 값은 행과 열의 위치로 입력하고, (2,4)위치에 alligator를 집어넣어 출력
'''

# #-----------------------------------
# def solution(r,c):
#     #빈 리스트 생성
#     ans = []
#     #반복문
#     for i in range(r):
#         tmp = []
#         for j in range(c):
#             tmp.append((i,j))
#         ans.append(tmp)
#     #최종 결과 리턴

#     #(2,4)위치에 alligator 입력하기
#     ans[2][4]= 'alligator'


#     return ans
# #-----------------------------------

# result = solution(4,5)
# print(result)

'''
[!]요소 찾기 문제 패턴
2차원 배열의 특정 위치에 값을 넣기
2차원 배열 특정 위치의 값을 찾기
주어진 2차원 배열[[150,180,160],[195,175,185],[188,166,155]]
n번쨰로 키가 큰 사람의 키는 몇인가?
'''

#----------------------------
def solution(ar,n): #ar(배열), n(몇번째)

    #정답을 저장할 변수
    answer = 0

    #빈 리스트 생성 -> 2차원 배열을 1차원으로 변환
    lst=[]

    #반복문 -> 중첩
    for i in range(len(ar)):
        for j in range(3):
            lst.append(ar[i][j])
    
    #정렬
    lst.sort(reverse=True)
    ans = lst[n-1]
    return lst, ans
    
#----------------------------
result = solution([[150,180,160],[195,175,185],[188,166,155]],3)
print(result)
