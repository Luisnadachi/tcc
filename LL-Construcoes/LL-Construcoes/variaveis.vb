Module variaveis
    Public permissao As String 'Login'

    'Cadastro de Cliente'
    Public idcliente As Integer
    Public nome_c As String
    Public cpf_c As String
    Public rg_c As String
    Public celular_c As String
    Public telefone_c As String
    Public data_c As String
    Public email_c As String
    Public logradouro_c As String
    Public cidade_c As String
    Public estado_c As String
    Public complemento_c As String
    Public cep_c As String
    Public numero_c As Integer
    Public bairro_c As String
    'Fim Cadastro de Cliente'

    'Cadastro de Fornecedores'
    Public idfornec As Integer
    Public nome_f As String
    Public cnpj_f As String
    Public infoad_f As String
    Public email_f As String
    Public celular_f As String
    Public telefone_f As String
    Public logradouro_f As String
    Public numero_f As Integer
    Public bairro_f As String
    Public complemento_f As String
    Public cep_f As String
    Public cidade_f As String
    Public estado_f As String
    Public banco_f As String
    Public agencia_f As String
    Public conta_f As String
    Public operacao_f As String
    'Fim Cadastro de Fornecedores'

    'Cadastro de Produtos'
    Public idproduto As Integer
    Public nome_p As String
    Public marca_p As String
    Public cor_p As String
    Public preco_p As Double
    Public estoque_p As Integer
    Public categoria_p As String
    Public subcategoria_p As String
    Public fornecedor_p As String
    Public desc_p As String
    Public img_p As String
    'Fim Cadastro de Produtos'

    'Cadastro de Funcionários'
    Public idfunc As Integer
    Public nome_func As String
    Public data_func As String
    Public cpf_func As String
    Public rg_func As String
    Public email_func As String
    Public tel_func As String
    Public cel_func As String
    Public usuario_func As String
    Public senha_func As String
    Public cargo_func As String
    Public logradouro_func As String
    Public numEnd_func As String
    Public bairro_func As String
    Public complemento_func As String
    Public cep_func As String
    Public cidade_func As String
    Public uf_func As String
    Public banco_func As String
    Public agencia_func As String
    Public conta_func As String
    Public operacao_func As String
    Public salario_func As Double
    Public vendas_func As String
    Public img_f As String
    'Fim Cadastro de Funcionários'

    'Outros'
    Public foto1 As Boolean = False
    Public imgnome As String
    Public foto2 As Boolean = False
    Public imgnome2 As String
    'Outros'
End Module
