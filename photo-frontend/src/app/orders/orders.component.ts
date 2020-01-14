import { Component, OnInit } from '@angular/core';
import { UserOrders } from '../_models/order';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.css']
})
export class OrdersComponent implements OnInit {
  public images: Array<Array<any>>= new Array<Array<any>>();

  base64textString: string;
  attached_image: any;
  flashMsg: string;
  orderId: number;
  constructor(public userOrders: UserOrders) { }

  ngOnInit() {
  }

  handleFiles(fileInput: Event,orderId:number) {
    this.orderId=orderId;
    var files = fileInput.target['files'];
    for (var i = 0; i < files.length; i++) {
     if( this.validateFile(files[i])){
      var reader = new FileReader();
      reader.onload = this._handleReaderLoaded.bind(this);
      reader.readAsBinaryString(files[i]);
     }else{
      //  show validation error message
     }

    } 


    // this.extention = file.name.substr((file.name.lastIndexOf('.') + 1)).toLowerCase();

  }

  _handleReaderLoaded(readerEvt) {
    var binaryString = readerEvt.target.result;
    this.base64textString = btoa(binaryString);
    this.attached_image = 'data:image/jpeg;base64,' + this.base64textString;
    // if (this.attached_image) {
    //   this.flashMsg = "Image uploaded successfully!";
    // }
    this.images[this.orderId] =this.attached_image;
  }

  validateFile(fileInput:any) {
    var imageArr = ['image/jpeg', 'image/jpg', 'image/png', 'image/gif'];

    if (fileInput.size > 10024000) {
      // $.growl.error({ title: 'Error', message: "File can not be larger than 1 MB" });
      return 0;
    }
    if (!imageArr.includes(fileInput.type)) {
      // $.growl.error({ title: 'Error', message: "Invalid file format." });
      return 0;
    }
    return 1;
  }

}
