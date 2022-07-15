#클래스 변수란 무엇인가

#[1] : create class
#--------------------------
class MyClass:

    # 클래스 변수
    a_var = 1250

    # 클래스 메서드
    def a_method(self):
        MyClass.a_var = 3000



#--------------------------

#[2] : using class
# 클래스 변수 호출 --> 클래스 변수는 클래스 외부에서 "클래스명.변수명"으로 접근이 가능
print(f"[1] 최초 클래스 변수의 초기 값 --> {MyClass.a_var}")

# 클래스 변수 값 수정
MyClass.a_var = 1500
print("[2]클래스 변수의 초기값을 1500으로 변경 --->",MyClass.a_var)

# 클래스 메서드 호출을 통해서 수정
m1 = MyClass()
m1.a_method()
print("[3] 클래스내 메서드를 호출해서 변수값 수정",MyClass.a_var)
#  print(MyClass.a_method()) # Err 발생
