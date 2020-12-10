
/* A Bison parser, made by GNU Bison 2.4.1.  */

/* Skeleton interface for Bison's Yacc-like parsers in C
   
      Copyright (C) 1984, 1989, 1990, 2000, 2001, 2002, 2003, 2004, 2005, 2006
   Free Software Foundation, Inc.
   
   This program is free software: you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation, either version 3 of the License, or
   (at your option) any later version.
   
   This program is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.
   
   You should have received a copy of the GNU General Public License
   along with this program.  If not, see <http://www.gnu.org/licenses/>.  */

/* As a special exception, you may create a larger work that contains
   part or all of the Bison parser skeleton and distribute that work
   under terms of your choice, so long as that work isn't itself a
   parser generator using the skeleton or a modified version thereof
   as a parser skeleton.  Alternatively, if you modify or redistribute
   the parser skeleton itself, you may (at your option) remove this
   special exception, which will cause the skeleton and the resulting
   Bison output files to be licensed under the GNU General Public
   License without this special exception.
   
   This special exception was added by the Free Software Foundation in
   version 2.2 of Bison.  */


/* Tokens.  */
#ifndef YYTOKENTYPE
# define YYTOKENTYPE
   /* Put the tokens into the symbol table, so that GDB and other debuggers
      know about them.  */
   enum yytokentype {
     PRNAME = 258,
     DIRNAM = 259,
     DATYPE = 260,
     NUBITS = 261,
     NBMANT = 262,
     NBEXPO = 263,
     NDSTAC = 264,
     SDEPTH = 265,
     NUIOIN = 266,
     NUIOOU = 267,
     NUGAIN = 268,
     TYPE = 269,
     INUM = 270,
     FNUM = 271,
     ID = 272,
     STRING = 273,
     IN = 274,
     OUT = 275,
     ABS = 276,
     SIGN = 277,
     RETURN = 278,
     WHILE = 279,
     IF = 280,
     ELSE = 281,
     SHIFTL = 282,
     SHIFTR = 283,
     SSHIFTR = 284,
     GREQU = 285,
     LESEQ = 286,
     EQU = 287,
     DIF = 288,
     LAND = 289,
     LOR = 290,
     NORM = 291
   };
#endif
/* Tokens.  */
#define PRNAME 258
#define DIRNAM 259
#define DATYPE 260
#define NUBITS 261
#define NBMANT 262
#define NBEXPO 263
#define NDSTAC 264
#define SDEPTH 265
#define NUIOIN 266
#define NUIOOU 267
#define NUGAIN 268
#define TYPE 269
#define INUM 270
#define FNUM 271
#define ID 272
#define STRING 273
#define IN 274
#define OUT 275
#define ABS 276
#define SIGN 277
#define RETURN 278
#define WHILE 279
#define IF 280
#define ELSE 281
#define SHIFTL 282
#define SHIFTR 283
#define SSHIFTR 284
#define GREQU 285
#define LESEQ 286
#define EQU 287
#define DIF 288
#define LAND 289
#define LOR 290
#define NORM 291




#if ! defined YYSTYPE && ! defined YYSTYPE_IS_DECLARED
typedef int YYSTYPE;
# define YYSTYPE_IS_TRIVIAL 1
# define yystype YYSTYPE /* obsolescent; will be withdrawn */
# define YYSTYPE_IS_DECLARED 1
#endif

extern YYSTYPE yylval;


