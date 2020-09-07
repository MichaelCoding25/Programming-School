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
mov bh, ch
mov ch, bh
mov ax, 2567h
mov bx, 2567h
mov ax, 2
mov bx, 3
mov cx, 4
mov dx, 5
mov ax, bx
mov bx, ax
mov bx, dx
mov ax, ax
mov ax, bx
mov ax, cx
mov dx, dx



exit:
	mov ax, 4c00h
	int 21h
END start