# Atividades\_LOPAL\_2026
Pablo Vinícius Alves Pisolato

## Meus projetos do primeiro semestre de Desenvolvimento de Sistemas em C#

* Calculadora IMC
* Calculadora
* Área


import express from "express";

const app = express();
const PORT = 3000;

app.use(express.json());

const CAPACIDADE = 20;
const PRECO_PRIMEIRA_HORA = 10;
const PRECO_HORA_ADICIONAL = 5;

let proximoID = 1;
let VEICULOS = [];
let HISTORICO = [];

app.get("/", (req, res) => {
  res.status(200).json({ msg: "Bem-vindo à API do Estacionamento!" });
});

app.get("/veiculos", (req, res) => {
  return res.status(200).json(VEICULOS);
});

app.post("/veiculos", (req, res) => {
  const { placa, modelo, cor } = req.body;

  if (VEICULOS.length >= CAPACIDADE) {
    return res.status(400).json({ msg: "Estacionamento lotado!" });
  }

  if (VEICULOS.some((v) => v.placa === placaNormalizada)){
    return res.status(409).json({
        msg: "veiculo já estacionado."
    })
  }

  if (
    ![placa, modelo, cor].every(
      (campo) => typeof campo === "string" && campo.trim()
    )
  ) {
    return res.status(400).json({
      msg: "Informe uma placa, modelo e cor válidos.",
    });
  }

  const placaNormalizada = placa.trim().toUpperCase();

  const jaEstacionado = VEICULOS.some((v) => v.placa === placaNormalizada);
  if (jaEstacionado) {
    return res.status(400).json({ msg: "Veículo já está no estacionamento." });
  }

  const veiculo = {
    id: proximoID++,
    placa: placaNormalizada,
    modelo: modelo.trim(),
    cor: cor.trim(),
    entrada: new Date().toLocaleString("pt-BR"),
  };

  VEICULOS.push(veiculo);

  return res.status(201).json({ msg: "Entrada registrada", veiculo });
});

app.get("/veiculos", (req, res) => {
    res.status(200).json({total: VEICULOS.length, VEICULOS});
});
app.get("/veiculos/:id", (req, res) => {})
app.get("/vagas", (req, res) => {})

app.listen(PORT, () => {
  console.log(`Servidor rodando em http://localhost:${PORT}`);
});
  

