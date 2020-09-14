<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Gallary.aspx.cs" Inherits="Gallary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


		<!-- Pirobox setup and styles -->
<script type="text/javascript" src="lib/pirobox.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        $().piroBox({
            my_speed: 400, //animation speed
            bg_alpha: 0.1, //background opacity
            slideShow: false, // true == slideshow on, false == slideshow off
            slideSpeed: 4, //slideshow duration in seconds(3 to 6 Recommended)
            close_all: '.piro_close,.piro_overlay'// add class .piro_overlay(with comma)if you want overlay click close piroBox

        });
    });
</script>

<link href="images/style.css" rel="stylesheet" type="text/css" />
<!-- Pirobox setup and styles end-->
<link href="styles.css" rel="stylesheet" type="text/css" />



  <div style="height:10px"></div>
        <div class="row">
          <div class="box_img2">
            <h1>Relocation Service</h1>
                <a href="packers/gallary_transport.jpg" class="pirobox_gal" title="Relocation services"><img src="packers/gallary_transport.jpg" alt="" /></a>
                <div class=" text_gal">
                	We provide complet loading of your valueble packed items with care. Our skilled and trained expert staff knows how to load goods well .
                    the heavy goods at the bootom & light weight & fragile items at top.We know how to place these goods in the vehicle so that while moving.  
                </div>                 
          </div>





            <div class="box_razd"></div>
          <div class="box_img2">
            <h1>Warehousing Service</h1>
                <a href="packers/about2.png" class="pirobox_gal" title="Warehousing Services"><img src="packers/about2.png" alt="" /></a>
                <div class=" text_gal">
                	ware Housing facilities are provided by us & the same is availabel at all our branches. Ample Ware Housing fcilites are availabel for House hold Goods.
                    furniture,industrial Goods & automobiles. Additionally, etc.          </div>                 
          </div>




           <div class="box_razd"></div>
          <div class="box_img2">
            <h1>Call us</h1>
                <a href="packers/gallary_call.jpg" class="pirobox_gal" title="Call us"><img src="packers/gallary_call.jpg" alt="" /></a>
                <div class=" text_gal">
                	 Hello.... customers your feedback are important for us. and any make problem in the our services so please call +(91)7874582550,Reloction also involves lot of paper works like custom clearence insurance.              </div>                 
          </div>



            <div style="clear: both;"></div>
      </div>
      <div style="height:10px"></div>
      <div class="razd_h"></div>
      <div style="height:10px"></div>
      <div class="row">
          <div class="box_img2">
            <h1>Packing Service</h1>
                <a href="packers/about1.png" class="pirobox_gal" title="Packing Services"><img src="packers/about1.png" alt="" /></a>
                <div class=" text_gal">
               We provid the best quality packing materials in all types of goods. and trained staff are work with us.
                    the heavy goods at the bootom & light weight & fragile items at top.We know how to place these goods in the vehicle so that while moving,          </div>                 
          </div>




           <div class="box_razd"></div>
          <div class="box_img2">
            <h1>Quality Material Packing</h1>
                <a href="packers/gallary_packing.png" class="pirobox_gal" title="Quality Material Packing"><img src="packers/gallary_packing.png" alt="" /></a>
                <div class=" text_gal">
                	   Today every now and rhen individuals. families and industries are relocation to differnet places Relocation involves hectic schedule of Packing and moving goods both within a country and outside it.            
                </div>                 
          </div>




            <div class="box_razd"></div>
          <div class="box_img2">
            <h1>Loading Services</h1>
                <a href="packers/gallary_office.jpg" class="pirobox_gal" title="Loading services"><img src="packers/gallary_office.jpg" alt="" /></a>
                <div class=" text_gal">
                 Shreeji packers and movers are provides the Loading services for the dalicate iteams and important iteams for the customers so we care for customers iteams.
                                 
          </div>

        </div>
        </div>
</asp:Content>

