﻿// 약수의 합
// https://programmers.co.kr/learn/courses/30/lessons/12928

namespace P_Algorithm_12928 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(12);
        }
    }

    //====================================//

    public class Solution {
        public int solution(int n) {
            int sum = 0;
            for(int i = 1; i <= n; i++) {
                if(n % i == 0) {
                    sum += i;
                }
            }
            return sum;
        }
    }

}
