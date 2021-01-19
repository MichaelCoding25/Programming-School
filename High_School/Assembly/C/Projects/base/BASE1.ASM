IDEAL
MODEL small
STACK 100h
DATASEG
;--------------------------
;Your variables here
;--------------------------
var1 db 5

CODESEG
start:
	mov ax, @data
	mov ds, ax
    mov ax, 0b800h
    mov es, ax
;--------------------------
;Your code here
;--------------------------
    mov bx, 0
    mov cx, 5
aaaa:
    mov [byte ptr es:bx], 'c'
    add bx, 2
    loop aaaa
	
	mov ah, 01
	int 21h
	
exit:
	mov ax, 4c00h
	int 21h
END start
