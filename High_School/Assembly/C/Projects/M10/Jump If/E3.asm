IDEAL
MODEL small
STACK 100h
DATASEG
Var1 dw 321h
Var2 dw 104h
;--------------------------
;Your variables here
;--------------------------
CODESEG
start:
	mov ax, @data
	mov ds, ax
;--------------------------
;Your code here
;--------------------------
	mov ax, [Var1]
	mov bx, [Var2]
	cmp ax, bx
	JA AX_is_one
	
AX_is_zero:
	mov ax, 0
	JMP exit
AX_is_one:
	mov ax, 1
exit:
	mov ax, 4c00h
	int 21h
END start 