<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="cinetec.index" %>

<!doctype html>
<html lang="pt-br">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">


    <link href="css/normalize.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/layout_home.css" rel="stylesheet" />

    <title>Cinetec</title>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top>
        <a class="navbar-brand" href="index.html"><img src="img/logo-p.png" /></a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNavDropdown">
            <ul class="navbar-nav">

                <li class="nav-item">
                    <a class="nav-link" href="#">Notícias</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Cinemas</a>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Estréias
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a class="dropdown-item" href="#">Em Cartaz</a>
                        <div class="dropdown-divider"></div>
                        <a class="dropdown-item" href="#">Em Breve</a>
                    </div>
                </li>

                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Gêneros
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a class="dropdown-item" href="#">Ação</a>
                        <a class="dropdown-item" href="#">Aventura</a>
                        <a class="dropdown-item" href="#">Comédia</a>
                        <a class="dropdown-item" href="#">Drama</a>
                        <a class="dropdown-item" href="#">Ficção</a>
                        <a class="dropdown-item" href="#">Romance</a>
                    </div>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Contato</a>
                </li>

            </ul>
        </div>
    </nav>


        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel" class="top-50">
            <ol class="carousel-indicators">
                <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="3"></li>
            </ol>

            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="img/img1.jpg" class="d-none d-md-block w-100">
                    <img src="img/img1v.jpg" class="d-sm-block d-md-none w-100">
                </div>
                <div class="carousel-item">
                    <img src="img/img2.jpg" class="d-none d-md-block w-100">
                    <img src="img/img2v.jpg" class="d-sm-block d-md-none w-100">
                </div>
                <div class="carousel-item">
                    <img src="img/img3.jpg" class="d-none d-md-block w-100">
                    <img src="img/img3v.jpg" class="d-sm-block d-md-none w-100">
                </div>
                <div class="carousel-item">
                    <img src="img/img4.jpg" class="d-none d-md-block w-100">
                    <img src="img/img4v.jpg" class="d-sm-block d-md-none w-100">
                </div>
            </div>

            <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>

            <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>

        </div>

    <!--começa a pagina a partir deste ponto o limitador-->
        <div class="limitador">
            <div class="titulo">notícias</div>

            <div class="row">
                <div class="col col-md-6 col-sm-12 col-12">
                    <div class="titulo-noticia">
                        Tudo o que sabemos sobre o filme do Coringa
                    </div>

                    <div class="imagem-noticia">
                        <img src="img/img-noticia.jpg" class="img-fluid img-100" />
                    </div>
                </div>


                <div class="col col-md-6 col-sm-12 col-12">
                    <div class="titulo-noticia">
                        Tudo o que sabemos sobre o filme do Coringa
                    </div>

                    <div class="imagem-noticia">
                        <img src="img/img-noticia.jpg" class="img-fluid img-100" />
                    </div>
                </div>

            </div><!--fim do class row-->

            <div class="row">
                <div class="col col-md-6 col-sm-12 col-12">
                    <div class="titulo-noticia">
                        Tudo o que sabemos sobre o filme do Coringa
                    </div>

                    <div class="imagem-noticia">
                        <img src="img/img-noticia.jpg" class="img-fluid img-100" />
                    </div>
                </div>


                <div class="col col-md-6 col-sm-12 col-12">
                    <div class="titulo-noticia">
                        Tudo o que sabemos sobre o filme do Coringa
                    </div>

                    <div class="imagem-noticia">
                        <img src="img/img-noticia.jpg" class="img-fluid img-100" />

                    </div>
                </div>
            </div> <!--fim do class row-->
            <!--propaganda no meio da página-->
            <div class="propaganda">
                <img src="img/prop.jpg" class="d-none d-md-block w-100"><!--imagem grande para tela grande-->
                <img src="img/prop2.jpg" class="d-block d-md-none w-100"><!--imagem pequena para tela de celular-->
            </div>


            <div class="titulo">filmes</div>
            <div class="row titulo-filme">em cartaz</div>



            <!--inicio do 1 carrossel de filmes abaixo da propaganda / DESKTOP-->
            <!--cd - CARTAZ DESKTOP-->
            <div id="carousel-cd" class="carousel slide d-none d-md-block" data-ride="carousel">

                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img src="img/filmes/F01.jpg" class="filmes">
                        <img src="img/filmes/F02.jpg" class="filmes">
                        <img src="img/filmes/F03.jpg" class="filmes">
                        <img src="img/filmes/F04.jpg" class="filmes">
                        <img src="img/filmes/F05.jpg" class="filmes">
                    </div>
                    <div class="carousel-item">
                        <img src="img/filmes/F06.jpg" class="filmes">
                        <img src="img/filmes/f07.jpg" class="filmes">
                        <img src="img/filmes/F08.jpg" class="filmes">
                        <img src="img/filmes/f09.jpg" class="filmes">
                        <img src="img/filmes/F10.jpg" class="filmes">
                    </div>

                </div>

                <a class="carousel-control-prev" href="#carouse-cd" role="button" data-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carousel-cd" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
            <!--fimm do carrossel de filmes DESKTOP-->
            <!--inicio do 1 carrossel de filmes abaixo da propaganda / mobile-->
            <!--cm - CARTAZ MOBILE-->
            <div id="carousel-cm" class="carousel slide d-block d-md-none" data-ride="carousel">

                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img src="img/filmes/F01.jpg" class="filmes-m">
                        <img src="img/filmes/F02.jpg" class="filmes-m">
                    </div>
                    <div class="carousel-item">
                        <img src="img/filmes/F03.jpg" class="filmes-m">
                        <img src="img/filmes/F04.jpg" class="filmes-m">
                    </div>
                    <div class="carousel-item">
                        <img src="img/filmes/F05.jpg" class="filmes-m">
                        <img src="img/filmes/F06.jpg" class="filmes-m">
                    </div>
                    <div class="carousel-item">
                        <img src="img/filmes/f07.jpg" class="filmes-m">
                        <img src="img/filmes/F08.jpg" class="filmes-m">
                    </div>
                    <div class="carousel-item">
                        <img src="img/filmes/f09.jpg" class="filmes-m">
                        <img src="img/filmes/F10.jpg" class="filmes-m">
                    </div>

                </div>

                <a class="carousel-control-prev" href="#carousel-cm" role="button" data-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carousel-cm" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
            <!--fimm do carrossel de filmes mobile-->





            <div class="row titulo-filme">em breve</div>

            <!--cd - CARTAZ DESKTOP-->
            <!--bd - EM BREVE DESKTOP-->
            <div id="carousel-bd" class="carousel slide d-none d-md-block" data-ride="carousel">
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img src="img/filmes/f12.jpg" class="filmes">
                        <img src="img/filmes/f13.jpg" class="filmes">
                        <img src="img/filmes/f14.jpg" class="filmes">
                        <img src="img/filmes/f15.jpg" class="filmes">
                        <img src="img/filmes/f16.jpg" class="filmes">
                    </div>
                    <div class="carousel-item">
                        <img src="img/filmes/f17.jpg" class="filmes">
                        <img src="img/filmes/f18.jpg" class="filmes">
                        <img src="img/filmes/f19.jpg" class="filmes">
                        <img src="img/filmes/f20.jpg" class="filmes">
                        <img src="img/filmes/f21.jpg" class="filmes">
                    </div>

                </div>

                <a class="carousel-control-prev" href="#carouse-bd" role="button" data-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carousel-bd" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>

            <!--fimm do carrossel de filmes DESKTOP-->
            <!--bcm - EM BREVE MOBILE-->
            <div id="carousel-bm" class="carousel slide d-block d-md-none" data-ride="carousel">

                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img src="img/filmes/f12.jpg" class="filmes-m">
                        <img src="img/filmes/f13.jpg" class="filmes-m">
                    </div>
                    <div class="carousel-item">
                        <img src="img/filmes/f14.jpg" class="filmes-m">
                        <img src="img/filmes/f15.jpg" class="filmes-m">
                    </div>
                    <div class="carousel-item">
                        <img src="img/filmes/f16.jpg" class="filmes-m">
                        <img src="img/filmes/f17.jpg" class="filmes-m">
                    </div>
                    <div class="carousel-item">
                        <img src="img/filmes/f18.jpg" class="filmes-m">
                        <img src="img/filmes/f19.jpg" class="filmes-m">
                    </div>
                    <div class="carousel-item">
                        <img src="img/filmes/f20.jpg" class="filmes-m">
                        <img src="img/filmes/f21.jpg" class="filmes-m">
                    </div>

                </div>

                <a class="carousel-control-prev" href="#carousel-bm" role="button" data-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carousel-bm" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
            <!--fimm do carrossel de filmes mobile-->


            <!--propaganda  ANTE DE CINEMAS  -->
            <div class="propaganda">
                <img src="img/prop.jpg" class="d-none d-md-block w-100"><!--imagem grande para tela grande-->
                <img src="img/prop2.jpg" class="d-block d-md-none w-100"><!--imagem pequena para tela de celular-->
            </div>


            <div class="trailer">

                <!-- 16:9 aspect ratio -->
                <div class="embed-responsive embed-responsive-16by9">
                    <iframe class="embed-responsive-item" src="https://www.youtube.com/embed/fxOEBm65oFo"></iframe>
                </div>



            <div class="titulo">cinemas</div>


            <!--inicio dos cinemas BAURU-->
            <div class="row titulo-cinema top20">bauru</div>
            <div class="row"> 
                <div class="col col-md-6 col-sm-12 col-12 top20">
                    <asp:Image runat="server" ID="imgb1" class="img-fluid img-100" />
                </div>

                <div class="col col-md-6 col-sm-12 col-12 top20">
                    <asp:Image runat="server" ID="imgb2" class="img-fluid img-100" />
                </div>
             </div><!--fim do class row-->


            <!--inicio dos cinemas JAÚ-->
            <div class="row titulo-cinema top20">jaú</div>
            <div class="row"> 
                <div class="col col-md-6 col-sm-12 col-12 top20">
                    <img src="img/Cinemas/J1.jpg" class="img-fluid img-100" />
                </div>

                <div class="col col-md-6 col-sm-12 col-12 top20">
                    <img src="img/Cinemas/J2.jpg" class="img-fluid img-100" />
                </div>
             </div><!--fim do class row-->





            <!--inicio dos cinemas BOTUCATU-->
            <div class="row titulo-cinema top20">botucatu</div>

            <div class="row"> 
                <div class="col col-md-6 col-sm-12 col-12 top20">
                    <asp:Image runat="server" ID="imgbt1" class="img-fluid img-100" />
                </div>

                <div class="col col-md-6 col-sm-12 col-12 top20">
                    <asp:Image runat="server" ID="imgbt2" class="img-fluid img-100" />
                </div>
             </div><!--fim do class row-->












            </div><!--fim do limitador-->








        </div>











    <script src="js/jquery-3.0.0.js"></script>
    <script src="js/bootstrap.js"></script>
    <script src="js/popper.js"></script>
</body>
</html>