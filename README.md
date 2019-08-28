# SAPHO
Scalable Architecture Processor for Hardware Optimization

>> A pastas Assembler e Compilador C contém o código fonte dos respectivos compiladores.
- Ao editar algum compilador, o arquivo executável (asm2mif ou mycomp) é gerado na pasta bin>release.
- O Assembler já está editado para aceitar o PSET e o PSETP. O compilador C ainda não reconhece o "@", falta arrumar isso no compilador C e no SAPHO.

>> A pasta HDL contém os módulos do processador do Quartus (aqueles arquivos que o arquivo .qip "busca" ao criarmos um processador)
- Falta editar o SAPHO para que o .qip busque o novo módulo (positivo.v), que é responsável pela nova instrução PSET e PSETP.
- Até configurar o .qip, o módulo positivo.v deve ser adicionado manualmente em cada projeto.
