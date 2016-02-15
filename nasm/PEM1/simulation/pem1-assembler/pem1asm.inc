%ifndef _ASM_PEM1ASM_INC_
%define _ASM_PEM1ASM_INC_

%include "errors.inc"
%include "syscalls.inc"
%include "fileio.inc"
%include "termio.inc"

%define ASCII_LF 10

; maximum argument count
%define ARGC 4

%macro BUFFER 1
        .start:     resb %1
        .length:    equ $-.start
    %endmacro
    
%macro syscall.write 1
        mov     rsi, %1
        mov     rdx, %1.length
        mov     rdi, STDOUT
        mov     rax, SYS_WRITE
        syscall
    %endmacro
    
    %macro syscall.read 1
        mov     rsi, %1
        mov     rdx, %1.length
        mov     rdi, STDIN
        mov     rax, SYS_READ
        syscall
    %endmacro
    
%elif
    %warning "pem1asm.inc already included"
%endif