window.ShowModal = (element) => {
  let modalInstance = new bootstrap.Modal(element);
  modalInstance.show();
};

window.HideModal = (element) => {
  let modalInstance = bootstrap.Modal.getInstance(element);
  if (modalInstance) {
    modalInstance.hide();
  }
};
