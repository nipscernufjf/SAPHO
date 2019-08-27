#include "eval.h"
#include "t2t.h"
#include "variaveis.h"
#include "labels.h"
#include "veri_comp.h"
#include <stdlib.h>
#include <stdio.h>
#include <math.h>
#include <string.h>

#define NBITS_OPC 6

FILE *f_data, *f_instr;

int  state = 0;     // estado do compilador
int  c_op;          // guarda opcode atual
int  pp;            // flag do pre-processador
int  nbopr;         // num de bits de operando

void eval_init(int prep)
{
    pp = prep;
    var_reset();

    if (pp)
    {
        n_ins = 0;
        n_dat = 0;
    }
    else
    {
        nbopr   = (n_ins > n_dat+ndstac) ? ceil(log2(n_ins)) : ceil(log2(n_dat+ndstac));
        f_data  = fopen(get_dname(), "w");
        f_instr = fopen(get_iname(), "w");
    }
}

void add_instr(int opc, int opr)
{
    if ( pp) n_ins++;
    if (!pp) fprintf(f_instr, "%s%s\n", itob(opc,NBITS_OPC), itob(opr,nbopr));
}

void add_data(int val)
{
    if (pp)
        n_dat++;
    else
    {
        int s = (float_point) ? nbmant + nbexpo + 1 : nbits;
        fprintf(f_data, "%s\n", itob(val,s));
    }
}

void operando(char *va, int is_const)
{
    if (find_var(va) == -1)
    {
        int val;
        if (float_point)
            val = (is_const) ? f2mf(va) : 0;
        else
            val = (is_const) ? atoi(va) : 0;

        add_var (va, val);
        add_data(    val);
    }

    add_instr(c_op, find_var(va));
}

void array_size(char *va)
{
    int i, inc = atoi(va);
    inc_vcont(inc-1);
    for (i = 0; i < inc; i++) add_data(0);
}

void eval_direct(int next_state)
{
    state = next_state;
}

void eval_opcode(int op, int next_state)
{
    c_op  = op;
    state = next_state;
    if (state == 0) add_instr(op,0);
}

void eval_opernd(char *va, int is_const)
{
    switch (state)
    {
        case  1: operando  (va, is_const);                       // operacoes com a ULA
                 state = 0; break;
        case  2: add_instr(c_op, find_label(va));                // label
                 state = 0; break;
        case  3: add_var(va,0);                                  // declarando array
                 state = 4; break;
        case  4: array_size(va);                                 // tamanho do array
                 state = 0; break;
        case  5: if (pp) set_name(va);                           // nome do processador
                 state = 0; break;
        case  6: if (pp) set_nbits (atoi(va));                   // numero de bits de dados
                 state = 0; break;
        case  7: if (pp) set_nbmant(atoi(va));                   // numero de bits de mantissa
                 state = 0; break;
        case  8: if (pp) set_nbexpo(atoi(va));                   // numero de bits do expoente
                 state = 0; break;
        case  9: if (pp) set_ndstac(atoi(va));                   // tamanho da pilha de dados
                 state = 0; break;
        case 10: if (pp) set_sdepth(atoi(va));                   // tamanho da pilha de instrucoes
                 state = 0; break;
        case 11: if (pp) set_nuioin(atoi(va));                   // numero de enderecoes de io - entrada
                 state = 0; break;
        case 12: if (pp) set_nuioou(atoi(va));                   // numero de enderecoes de io - saida
                 state = 0; break;
        case 13: if (pp) set_float_point(atoi(va));              // 1 para ponto-flutuante e 0 para ponto-fixo
                 state = 0; break;
        case 14: if (pp)                                         // diretorio do processador
                 {
                     va[strlen(va)-1] = 92; // trocar ultima aspas por barra invertida
                     set_dir(va);
                 }
                 state = 0; break;
    }
}

void eval_label(char *la)
{
    if (pp) add_label(la, n_ins);
}

void eval_finish()
{
    int i;
    fclose(f_instr);
    int s = (float_point) ? nbmant + nbexpo + 1 : nbits;
	for (i=0; i<ndstac; i++) fprintf(f_data, "%s\n", itob(0,s));
    fclose(f_data);
    build_vfile();
}
