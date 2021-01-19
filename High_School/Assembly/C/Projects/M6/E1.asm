IDEAL
MODEL small
STACK 100h
DATASEG

ArrayOfTenFives db 10 dup (5)
ArrayOf1234 db 8 dup (1,2,3,4)

CODESEG
start:
	mov ax, @data
	mov ds, ax

exit:
	mov ax, 4c00h
	int 21h
END start