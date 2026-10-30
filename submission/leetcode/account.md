# Reverse String (LeetCode #344)

An efficient, in-place C# solution for reversing a character array.

[![LeetCode](https://img.shields.io/badge/LeetCode-344._Reverse_String-FFA116?style=for-the-badge&logo=leetcode&logoColor=black)](https://leetcode.com/problems/reverse-string/description/)
[![C#](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Time Complexity](<https://img.shields.io/badge/Time-O(N)-brightgreen?style=for-the-badge>)]()
[![Space Complexity](<https://img.shields.io/badge/Space-O(1)-brightgreen?style=for-the-badge>)]()

---

## Problem Description

Write a function that reverses a string. The input string is given as an array of characters `s`.

You must do this by modifying the input array **in-place** with $O(1)$ extra memory.

### Constraints

- $1 \le \text{s.length} \le 10^5$
- `s[i]` is a printable ASCII character.

---

## Algorithm & Approach

The solution implements a **symmetric index swap** using a single loop:

1. Loop from index `i = 0` until reaching the array midpoint (`i < s.Length - i - 1`).
2. Swap the character at `s[i]` with its counterpart at `s[s.Length - i - 1]`.
3. Stopping at the midpoint ensures elements are swapped exactly once without reversing back to the original order.

---

## C# Implementation

```csharp
public class Solution {
    public void ReverseString(char[] s) {
        for (int i = 0; i < s.Length - i - 1; i++) {
            Swap(s, i, s.Length - i - 1);
        }
    }

    private void Swap(char[] s, int left, int right) {
        char temp = s[left];
        s[left] = s[right];
        s[right] = temp;
    }
}
```
