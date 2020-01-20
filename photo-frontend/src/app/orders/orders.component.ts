import { Component, OnInit } from '@angular/core';
import { UserOrders, OrderPhotos } from '../_models/order';
import { ImageUploadService } from '../_services/image-upload.service';
import { OrderService } from '../_services/order.service';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.css']
})
export class OrdersComponent implements OnInit {
  public images: Array<Array<string>> = new Array<Array<string>>();

  // base64textString: string;
  // attached_image: any;
  // flashMsg: string;
  orderId: number;
  // constructor(public userOrders: UserOrders) { }

  ngOnInit() {
  }

  // handleFiles(fileInput: Event,orderId:number) {
  //   this.orderId=orderId;
  //   var files = fileInput.target['files'];
  //   for (var i = 0; i < files.length; i++) {
  //    if( this.validateFile(files[i])){
  //     var reader = new FileReader();
  //     reader.onload = this._handleReaderLoaded.bind(this);
  //     reader.readAsBinaryString(files[i]);
  //    }else{
  //     //  show validation error message
  //    }

  //   } 


  //   // this.extention = file.name.substr((file.name.lastIndexOf('.') + 1)).toLowerCase();

  // }

  // _handleReaderLoaded(readerEvt) {
  //   var binaryString = readerEvt.target.result;
  //   this.base64textString = btoa(binaryString);
  //   this.attached_image = 'data:image/jpeg;base64,' + this.base64textString;
  //   // if (this.attached_image) {
  //   //   this.flashMsg = "Image uploaded successfully!";
  //   // }
  //   this.images[this.orderId] == undefined ? this.images[this.orderId] = new Array<any>(): null;
  //   this.images[this.orderId].push(this.attached_image);
  // }

  // validateFile(fileInput:any) {
  //   var imageArr = ['image/jpeg', 'image/jpg', 'image/png', 'image/gif'];

  //   if (fileInput.size > 10024000) {
  //     // $.growl.error({ title: 'Error', message: "File can not be larger than 1 MB" });
  //     return 0;
  //   }
  //   if (!imageArr.includes(fileInput.type)) {
  //     // $.growl.error({ title: 'Error', message: "Invalid file format." });
  //     return 0;
  //   }
  //   return 1;
  // }
  removePhotoFromOrder(orderId: number, index: number) {
    this.images[orderId].splice(index, 1);
  }

  imageObjs: FileList;
  imageUrl: string;

  constructor(private imageUploadService: ImageUploadService, public userOrders: UserOrders, private orderService: OrderService) { }

  onImagePicked(event: Event, orderId: number): void {
    //  const FILE = (event.target as HTMLInputElement).files[0];
    //  this.imageObj = FILE;
    this.orderId = orderId;
    const FILES = (event.target as HTMLInputElement).files;
    this.imageObjs = FILES;
    for (var i = 0; i < this.imageObjs.length; i++) {
      const imageForm = new FormData();
      imageForm.append('image', this.imageObjs.item(i));
      this.imageUploadService.imageUpload(imageForm).subscribe(res => {
        this.images[this.orderId] == undefined ? this.images[this.orderId] = new Array<any>() : null;
        this.images[this.orderId].push(res['image'])
      });
    }
  }

  saveImagesForOrder(orderId: number) {
    var photos = new OrderPhotos();
    photos.orderId = orderId;
    photos.photos = this.images[orderId];
    this.orderService.uploadPhotosToOrder(photos).
      subscribe((result) => {
        if (result == 1)
          alert(`photos uploaded successfully for order: ${orderId}`);
      },
        error => {
          console.log("error")
        });


  }

}
