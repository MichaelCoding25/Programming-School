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
	mov ax, 3bh
	cmp ax, 0
	JLE exit
	dec ax
exit:
	mov ax, 4c00h
	int 21h
END start 