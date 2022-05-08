<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="OnlineMedicineDonationToNgo.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div data-py="scroll" id="div1">

        <div class="container"  >
            <div class="row mx-lg-5 my-lg-5">
                <div class="col-6 p-5">
                    <h1>Help the Needy in their Need !</h1>
                    <br /> 
                    <p><i>Come ahead and donate to make sure no one will left with basic medical necessity</i></p>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Donate !" CssClass="btn btn-success" OnClick="Button1_Click"/>
                </div>
                <div class="col-6">
                    <div class="p-3">
                        <img src="Imgs/homeImage1.jpg" class="img-fluid rounded-circle border border-dark" alt="hel">
                    </div>
                </div>
            </div>
        </div>
    

    
        <div class="container"  >
            <div class="row mx-lg-5 my-lg-5">

                <div class=" col-6 p-3">
                        <img src="Imgs/homeImage2.jpg" class="img-fluid rounded-circle border border-dark" alt="hel">
                 </div>

                <div class="col-6">

                    <div class="p-5">
                        <h1>Millions life can be saved</h1>
                        <br />
                        <p><i>In the face of disaster and suffering there is a natural human impulse to reach out and
                            help those in need. Medicines are an essential element in alleviating suffering, and
                            international humanitarian relief efforts can greatly benefit from donations of
                            appropriate drugs.</i>
                        </p>
                    </div>

                </div>

            </div>

        </div>

    </div>

    <div class="container-fluid bg-success p-5" data-py="scroll" id="div2">
        <div class="container ">
            <h3>About </h3>
            <br />
            <p >
                <i>My website ‘Cure4Everyone’, collect the unused medicines from the people who have 
                completely recovered from the illness and do not require the medicines anymore. After the 
                collection of these medicines, they would be handed over to the NGO's which would check 
                the medicines and then if approved will be given to the people directly or to the hospitals 
                who will be giving out these medicines for free.
                </i>
            </p>
        </div>
    </div>

    <!-- Footer Elements -->
            <div class="container " >

                <!-- Grid row-->
                <div class="row">

                    <!-- Grid column -->
                    <div class="col-md-12 py-5">
                        <div class="mb-5 flex-center">
                            <h3>Contact</h3>
                            
                            <br />
                            
                            <a href="https://www.facebook.com/" title="Facebook">
                                <img src="Imgs/facebook.png" class="rounded-circle" height="50px"/>
                            </a>
                            
                            <a href="https://mail.google.com/" title="Gmail">
                                <img src="Imgs/google.jpg" class="rounded-circle ml-5" height="50px"/>
                            </a>

                            <a href="https://www.instagram.com/" title="instagram">
                                <img src="Imgs/instagram.png" class="rounded-circle ml-5" height="50px"/>
                            </a>
                            
                        </div>
                    </div>
                    <!-- Grid column -->

                </div>
                <!-- Grid row-->

            </div>
            <!-- Footer Elements -->
    
</asp:Content>
