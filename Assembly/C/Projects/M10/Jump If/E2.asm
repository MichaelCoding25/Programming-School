IDEAL
MODEL small
STACK 100h
DATASEG

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
	mov ax, 4fah
	mov bx, 4fah
	cmp ax, bx
	JE exit
	mov ax, bx
exit:
	mov ax, 4c00h
	int 21h
END start 