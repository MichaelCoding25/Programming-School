IDEAL
MODEL small
STACK 100h
DATASEG

NameFL db 15 dup(?)
PNum db '0527030633 '
Email db 'mikispector2@gmail.com'
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
	lea bx, [NameFL]
	mov [byte ptr bx], 'M'
	inc bx
	mov [byte ptr bx], 'i'
	inc bx
	mov [byte ptr bx], 'c'
	inc bx
	mov [byte ptr bx], 'h'
	inc bx
	mov [byte ptr bx], 'a'
	inc bx
	mov [byte ptr bx], 'e'
	inc bx
	mov [byte ptr bx], 'l'
	inc bx
	mov [byte ptr bx], ' '
	inc bx
	mov [byte ptr bx], 'S'
	inc bx
	mov [byte ptr bx], 'p'
	inc bx
	mov [byte ptr bx], 'e'
	inc bx
	mov [byte ptr bx], 'c'
	inc bx
	mov [byte ptr bx], 't'
	inc bx
	mov [byte ptr bx], 'o'
	inc bx
	mov [byte ptr bx], 'r'
exit:
	mov ax, 4c00h
	int 21h
END start