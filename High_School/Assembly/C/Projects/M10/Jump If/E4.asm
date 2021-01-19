IDEAL
MODEL small
STACK 100h
DATASEG
var1 db 15
var2 db 15
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
	mov ah, [var1]
	mov bh, [var2]
	cmp ah, bh
	JNE var1_var2_not_equal
	add ah, bh
	JMP exit
var1_var2_not_equal:
	sub ah, bh
exit:
	mov ax, 4c00h
	int 21h
END start 