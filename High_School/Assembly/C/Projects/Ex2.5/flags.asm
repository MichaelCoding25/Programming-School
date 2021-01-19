;Author: Michael Spector
;Exercise: 5.2
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
	mov al, 47h
	mov ah, 47h
	sub al, ah 
	
	mov al, 0FFh
	mov ah, 01h
	add al, ah


exit:
	mov ax, 4c00h
	int 21h
END start