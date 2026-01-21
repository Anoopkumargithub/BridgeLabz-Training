# BridgeLabz-Training

# My Reviews

## PostFix (Postfix Expression Evaluator)
- **Date solved:** January 21, 2026
- **Language:** C#
- **Location:** `review/PostFix.cs`
- **What it does:** Evaluates arithmetic expressions written in postfix (Reverse Polish) notation using a stack.

### How it works
1. Iterate through each character in the expression.
2. If the character is a digit, push its integer value onto the stack.
3. If the character is an operator (`+`, `-`, `*`, `/`), pop the top two values, apply the operator, and push the result back.
4. After processing all characters, the single value on the stack is the result.

### Example
- Expression: `13+2*2`
- Steps:
  - Push `1`, push `3`, apply `+` → push `4`
  - Push `2`, apply `*` → push `8`
  - Push `2`, apply `*` → push `16`
- **Result:** `16`

### Running the program
From the repository root:
```bash
dotnet run --project review/PostFix.csproj
```

### Notes / Possible improvements
- Add input validation for malformed expressions.
- Extend to support multi-digit numbers and whitespace handling.
- Add unit tests covering valid/invalid expressions and division edge cases.